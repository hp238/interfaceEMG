using System;
using System.Collections.Generic;

static class MyExtensions
{
	private static Random rng = new Random();

	public static void Shuffle<T>(this IList<T> list)
	{
		int n = list.Count;
		while (n > 1)
		{
			n--;
			int k = rng.Next(n + 1);
			T value = list[k];
			list[k] = list[n];
			list[n] = value;
		}
	}
}

public class Maze
{
	private Random rng = new Random();
	private int width, height;

	public Maze(int w, int h)
	{
		this.width = w;
		this.height = h;
	}

	public List<Tuple<int, int>> FindNeighbors(int r, int c, int[,] grid, int is_wall = 0)
	{
		List<Tuple<int, int>> ns = new List<Tuple<int, int>>();

		if (r > 1 && grid[r - 2, c] == is_wall)
			ns.Add(new Tuple<int, int>(r - 2, c));

		if (r < this.height - 2 && grid[r + 2, c] == is_wall)
			ns.Add(new Tuple<int, int>(r + 2, c));

		if (c > 1 && grid[r, c - 2] == is_wall)
			ns.Add(new Tuple<int, int>(r, c - 2));

		if (c < this.width - 2 && grid[r, c + 2] == is_wall)
			ns.Add(new Tuple<int, int>(r, c + 2));

		ns.Shuffle();

		return ns;
	}

	public int[,] Generate()
	{
		int[,] grid = new int[this.height, this.width];

		for (int i = 0; i < this.height; i++)
		{
			for (int j = 0; j < this.width; j++)
			{
				grid[i, j] = 1;
			}
		}

		int crow = 0;
		int ccol = 0;

		int startrow = crow, startcol = ccol;

		List<Tuple<int, int>> track = new List<Tuple<int, int>>();
		track.Add(new Tuple<int, int>(crow, ccol));

		grid[crow, ccol] = 0;

		while (track.Count > 0)
		{
			Tuple<int, int> lastTrack = track[track.Count - 1];
			crow = lastTrack.Item1;
			ccol = lastTrack.Item2;

			List<Tuple<int, int>> neighbors = this.FindNeighbors(crow, ccol, grid, 1);

			if (neighbors.Count == 0)
			{
				track.RemoveAt(track.Count - 1);
			}
			else
			{
				Tuple<int, int> neighbor = neighbors[0];
				int nrow = neighbor.Item1;
				int ncol = neighbor.Item2;

				grid[nrow, ncol] = 0;
				grid[(nrow + crow) / 2, (ncol + ccol) / 2] = 0;

				track.Add(new Tuple<int, int>(nrow, ncol));
			}
		}

		grid[startrow, startcol] = 2;
		grid[this.height - 2, this.width - 2] = 3;

		return grid;
	}
}